using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using qualityBackup.Models;
using qualityBackup.Resource;

namespace qualityBackup.Profile
{
    public class MappingProfile:AutoMapper.Profile 
    {
        public MappingProfile() {
            CreateMap<Subscripcion, SubscripcionResource>();
            CreateMap<SubscripcionResource, Subscripcion>();
            CreateMap<Clase, ClaseResource>();
            CreateMap<ClaseResource, Clase>();

        }
    }
}