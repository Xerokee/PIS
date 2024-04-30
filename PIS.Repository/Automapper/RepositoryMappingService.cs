using AutoMapper;
using PIS.DAL.DataModel;
using PIS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PIS.Repository.Automapper
{
    public class RepositoryMappingService : IRepositoryMappingService
    {
        public Mapper mapper;

        public RepositoryMappingService()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<PisUsersMmargeta, UsersDomain>(); //ruta baza - GUI
                    cfg.CreateMap<UsersDomain, PisUsersMmargeta>(); //ruta GUI - baza

                });
            mapper = new Mapper(config);
        }
        public TDestination Map<TDestination>(object source)
        {
            return mapper.Map<TDestination>(source);
        }
    }
}