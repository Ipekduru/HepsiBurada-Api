using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;


namespace HepsiSln.Application.Behaviours
{
    // Bu behaviour'un amacı, MediatR pipeline'ına FluentValidation doğrulamasını eklemektir.
    // CQRS ve MediatR yapısında her işlem bir Request ve bir Response üzerinden yürür.
    // PipelineBehavior, bir middleware (ara katman) gibi çalışır; 
    // her Request MediatR tarafından işlenmeden önce bu behaviour araya girer.
    // Böylece Request'i yakalayıp FluentValidation kurallarını çalıştırabilir,
    // geçersiz isteklere işlemin daha başında müdahale etmiş oluruz.
    // Yani bu yapı, tüm Command ve Query'lerde otomatik doğrulama yapmamızı sağlar.

    public class FluentValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        // Bu constructor, ilgili TRequest için uygulanmış TÜM FluentValidation 
        // validatorlarını DI’dan (Dependency Injection) alır. 
        // IEnumerable<IValidator<TRequest>> kullanmamızın sebebi, 
        // bir request için birden fazla validator olabileceği ve hepsinin 
        // pipeline'da sırayla çalıştırılması gerektiğidir.
        private readonly IEnumerable<IValidator<TRequest>> validator;



        // IEnumerable<T>  : Birden fazla öğeyi (liste, dizi vb.) temsil eden koleksiyon arayüzüdür.
        // IValidator<T>   : FluentValidation'ın, T tipi için doğrulama kurallarını tanımlayan arayüzüdür.

        public FluentValidationBehaviour(IEnumerable<IValidator<TRequest>>validator)
        {
            this.validator = validator;
        }
        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            // request nesnem ile gelen contexti validation context ile yakalıyorum ve bunu işleme fırstaı buluyorum 
            var context = new ValidationContext<TRequest>(request);
            // tüm hataların hepsi burada toplanacak
            var failtures =validator
                .Select(v=>v.Validate(context))// contextten gelen veriler işlenir 
                .SelectMany(result=>result.Errors)// birden fazla olması durumunda 
                .GroupBy(x=>x.ErrorMessage)
                .Select(x=>x.First())
                .Where(y=>y!=null)
                .ToList();
        
            if(failtures.Any())
                // eğer hata varsa validasyon hatası fırlatıyorum 
                throw new ValidationException(failtures);


            return next();


        }
    }
}
