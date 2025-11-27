using AutoMapper.Internal;
using AutoMapper;
using HepsiSln.Application.Interfaces.AutoMappers;
using IMapper = AutoMapper.IMapper;

namespace HepsiSln.Mapper.AutoMapper
{
    public class Mapper : Application.Interfaces.AutoMappers.IMapper
    {
        public static List<TypePair> typePairs = new();
        private IMapper MapperContainer;

        public TDestination Map<TDestination, TSource>(TSource source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            return MapperContainer.Map<TSource, TDestination>(source);
        }

        public IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            return MapperContainer.Map<IList<TSource>, IList<TDestination>>(source);
        }

        public TDestination Map<TDestination>(object source, string? ignore = null)
        {
            Config<TDestination,object>(5, ignore);
            return MapperContainer.Map<object, TDestination>(source);
        }

       

        //CONFIG
        // Bu metot, mapleme sırasında kullanılacak kuralları kaydetmek içindir.


        //DEPTH
        // depth automapper sınıfında default olarak 5tir
        // kaç seviyeye kadar nested mapping yapılacağını
        // yani iç içe nesnelerin derinliğini belirliyor

        //IGNORE
        // mapleme sırasında hangi property görmezden gelinecek 
        protected void Config<TDestinatiion, TSource>(int depth = 5, string? ignore = null)
        {
            // bu source destination tiplerini kaydeder 
            var typePair = new TypePair(typeof(TSource), typeof(TDestinatiion));
            // bu kısımda eğer listeye  daha önce eklendiyse ve herhangi bir ignore işlemi yoksa çık 
            if (typePairs.Any(a => a.DestinationType == typePair.DestinationType && a.SourceType == typePair.SourceType) && ignore == null) return;

            // typepair listeye ekleniyor 
            typePairs.Add(typePair);
            // typepairs listesindeki her kural automappera createmap olarak kaydediliyr config bir kez çalıştığında sadece o anki eşleşme değil hepsi automappera yükleniyor 
            var config = new MapperConfiguration(cfg =>
            {
                foreach (var item in typePairs)
                {
                    // ignore var ise o                                                      property eklenmesin 
                    if (ignore is not null)
                        cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ForMember(ignore, x => x.Ignore()).ReverseMap();
                    // ignore yok ise çift yönlü map 
                    else
                        cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ReverseMap();
                }
            });
            MapperContainer = config.CreateMapper();

        }

    }

}
