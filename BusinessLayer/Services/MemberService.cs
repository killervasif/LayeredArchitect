using AutoMapper;
using BusinessLayer.DTO;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repository;
        private readonly IMapper _mapper;

        public MemberService(IMemberRepository repository)
        {
            _repository = repository;
            _mapper = new MapperConfiguration(cfg => cfg.CreateMap<Member, MemberDTO>()).CreateMapper();
        }

        public void AddMember(MemberDTO memberDTO)
        {
            _repository.Create(_mapper.Map<Member>(memberDTO));
        }

        public void DeleteMember(int id)
        {
            _repository.Delete(id);
        }

        public MemberDTO GetMember(int id)
        {
            return _mapper.Map<MemberDTO>(_repository.Get(id));
        }

        public IEnumerable<MemberDTO> GetMembers()
        {
            return _mapper.Map<IEnumerable<Member>, List<MemberDTO>>(_repository.GetAll());
        }
    }
}
