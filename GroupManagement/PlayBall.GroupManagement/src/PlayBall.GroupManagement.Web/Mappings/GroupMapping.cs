using PlayBall.GroupManagement.Business.Models;
using PlayBall.GroupManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace PlayBall.GroupManagement.Web.Mappings
{
    public static class GroupMapping
    {
        public static GroupViewModel ToViewModel(this Group model)
        {
            return model != null ? new GroupViewModel
            {
                Id = model.Id,
                Name = model.Name
            } : null;
        }

        public static Group ToServiceModel(this GroupViewModel model)
        {
            return model != null ? new Group
            {
                Id = model.Id,
                Name = model.Name
            } : null;
        }

        public static IReadOnlyCollection<GroupViewModel> ToViewModel(this IReadOnlyCollection<Group> models)
        {
            if (models == null || models.Count <= 0)
            {
                return Array.Empty<GroupViewModel>();
            }
            var groups = new GroupViewModel[models.Count];
            int i = 0;
            foreach (var model in models)
            {
                groups[i] = new GroupViewModel
                {
                    Id = model.Id,
                    Name = model.Name
                };
                i++;
            }
            return new ReadOnlyCollection<GroupViewModel>(groups);
        }
    }
}
