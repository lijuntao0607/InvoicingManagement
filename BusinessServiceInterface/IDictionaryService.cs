using System;
using System.Collections.Generic;
using System.Text;
using DomainModule;
using System.Collections;

namespace BusinessServiceInterface
{
    public interface IDictionaryService
    {
        /// <summary>
        /// 加载系统所有字典
        /// </summary>
        /// <returns></returns>
        IDictionary<string, IList<SystemDictionary>> GetAllDictionary();

        void SaveRange(ArrayList list);
        void SaveRange(IList<SystemDictionary> list);
        void SaveRange(string entityName, System.Collections.ArrayList list);
        void Delete(string id);
        void Delete(SystemDictionary dic);
        void Save(object obj);
    }
}
