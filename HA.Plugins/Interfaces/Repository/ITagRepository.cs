using HA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Plugins.Interfaces.Repository
{
    public interface ITagRepository
    {
        IEnumerable<Tag> GetTags();

        Tag GetTagById(int id);

        void AddTag(Tag tag);

        void UpdateTag(Tag tag);

        void DeleteTag(int id);

        void DeleteTag(Tag tag);
    }
}
