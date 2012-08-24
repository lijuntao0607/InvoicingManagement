using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace BusinessService
{
    public class SystemControl
    {
        public static void SystemInit()
        {
            //初始化Service
            SystemVariable.CategoryService = new CategoryService();
            SystemVariable.UserService = new UserService();
            SystemVariable.ProductService = new ProductService();
            SystemVariable.DictionaryService =new DictionaryService();
            SystemVariable.StorageInService = new StorageInService();
            SystemVariable.StorageOutService = new StorageOutService();
            SystemVariable.WarehouseService = new WarehouseService();
            //加载所有产品类别
            SystemVariable.CategoryList = SystemVariable.CategoryService.GetAll();
            //加载系统字典
            SystemVariable.SystemDictionarySet = SystemVariable.DictionaryService.GetAllDictionary();

        }
    }
}
