using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetMemberIDs()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MemberObject> GetMembers()
        {
            throw new NotImplementedException();
        }

        public void InsertMember(MemberObject user)
        {
            throw new NotImplementedException();
        }

        public MemberObject Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void UpdateMember(MemberObject user)
        {
            throw new NotImplementedException();
        }
    }
}
