﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;



namespace Asp.NetCoreProject.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {

        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke() {

            var values = featureManager.TGetList();


            return View(values);
        }
    }
}