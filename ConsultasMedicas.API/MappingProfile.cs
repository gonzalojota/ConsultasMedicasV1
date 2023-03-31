using AutoMapper;
using ConsultasMedicas.Common.DTOs;
using ConsultasMedicas.Core.Entities;

namespace ConsultasMedicas.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Consulta, ConsultaDTO>().ReverseMap();

            CreateMap<Paciente, PacienteDTO>();

            CreateMap<PacienteCreateDto, Paciente>()
                .ForMember(dest => dest.FechaCreacion, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.FechaModificacion, opt => opt.MapFrom(src => DateTime.UtcNow));

            CreateMap<PacienteUpdateDto, Paciente>()
                .ForMember(dest => dest.FechaModificacion, opt => opt.MapFrom(src => DateTime.UtcNow));

            CreateMap<Medico, MedicoDTO>().ReverseMap();

            CreateMap<Notificacion, NotificacionDTO>().ReverseMap();
        }
    }
}
