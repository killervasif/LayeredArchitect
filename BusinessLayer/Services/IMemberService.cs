using BusinessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IMemberService
    {
        void AddMember(MemberDTO memberDTO);
        void DeleteMember(int id);
        MemberDTO GetMember(int id);
        IEnumerable<MemberDTO> GetMembers();
    }
}
