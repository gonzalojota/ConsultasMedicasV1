using AutoMapper;
using ConsultasMedicas.Common.DTOs;
using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Core.Interfaces;
using ConsultasMedicas.Core.Repositories;

namespace ConsultasMedicas.Core.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IMapper _mapper;

        public PacienteService(IPacienteRepository pacienteRepository, IMapper mapper)
        {
            _pacienteRepository = pacienteRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PacienteDTO>> GetAllPacientesAsync()
        {
            var pacientes = await _pacienteRepository.GetAllPacientesAsync();
            var pacientesDto = _mapper.Map<IEnumerable<PacienteDTO>>(pacientes);
            return pacientesDto;
        }

        public async Task<PacienteDTO> GetPacienteByIdAsync(int id)
        {
            var paciente = await _pacienteRepository.GetPacienteByIdAsync(id);
            var pacienteDto = _mapper.Map<PacienteDTO>(paciente);
            return pacienteDto;
        }

        public async Task<bool> AddPacienteAsync(PacienteCreateDto pacienteCreacionalDto)
        {
            var paciente = _mapper.Map<Paciente>(pacienteCreacionalDto);
            await _pacienteRepository.AddPacienteAsync(paciente);
            return true;
        }

        public async Task<bool> UpdatePacienteAsync(int id, PacienteUpdateDto pacienteActualizacionDto)
        {
            var existingPaciente = await _pacienteRepository.GetPacienteByIdAsync(id);
            if (existingPaciente != null)
            {
                _mapper.Map(pacienteActualizacionDto, existingPaciente);
                await _pacienteRepository.UpdatePacienteAsync(existingPaciente);
                return true;
            }
            return false;
        }

        public async Task<bool> DeletePacienteAsync(int id)
        {
            var paciente = await _pacienteRepository.GetPacienteByIdAsync(id);
            if (paciente != null)
            {
                await _pacienteRepository.DeletePacienteAsync(paciente.Id);
                return true;
            }
            return false;
        }
    }
}
