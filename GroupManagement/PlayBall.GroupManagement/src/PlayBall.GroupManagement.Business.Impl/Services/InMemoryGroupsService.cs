using PlayBall.GroupManagement.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayBall.GroupManagement.Business.Services.Impl
{
    public class InMemoryGroupsService : IGroupsService
    {
        private readonly List<Group> _groups = new List<Group>();
        private long _currentId = 1;

        public IReadOnlyCollection<Group> GetAll()
        {
            return _groups.AsReadOnly();
        }

        public Group GetById(long Id)
        {
            return _groups.SingleOrDefault(s => s.Id == Id);
        }

        public Group Update(Group group)
        {
            var g = GetById(group.Id);
            if (g == null)
            {
                return null;
            }
            g.Name = group.Name;
            return g;
        }
        public Group Add(Group group)
        {
            if (group == null)
            {
                return null;
            }

            group.Id = ++_currentId;
            _groups.Add(group);

            return group;
        }
    }
}
