using System;
using System.Collections.Generic;
using System.Text;
using DomainModule;
using BusinessService;
using BusinessServiceInterface;
using ViewModel;

namespace BusinessService
{
    public class SystemVariable
    {
        
        public static IUserService UserService;
        public static IProductService ProductService;
        public static ICategoryService CategoryService;
        public static IDictionaryService DictionaryService;
        public static IStorageInService StorageInService;
        public static IStorageOutService StorageOutService;
        public static IWarehouseService WarehouseService;
        public static UserInfo LoginUser;
        /// <summary>
        /// 系统字典类别
        /// </summary>
        public static ComboxItem[] DictionaryCateList = new ComboxItem[] {
            new ComboxItem{Name="计量单位",Value=EnumDictionary.Unit.ToString() }
        };



        public static IList<Category> CategoryList;
        public static IDictionary<string, IList<SystemDictionary>> SystemDictionarySet;
    }
}
