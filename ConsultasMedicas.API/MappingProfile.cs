using AutoMapper;
using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Common.DTOs;

namespace ConsultasMedicas.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Consulta, ConsultaDTO>().ReverseMap();
            CreateMap<Paciente, PacienteDTO>().ReverseMap();
            CreateMap<PacienteCreacionalDTO, Paciente>().ReverseMap();
            CreateMap<Medico, MedicoDTO>().ReverseMap();
            CreateMap<Notificacion, NotificacionDTO>().ReverseMap();
        }
    }
}
