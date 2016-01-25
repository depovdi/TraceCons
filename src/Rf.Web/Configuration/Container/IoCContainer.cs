﻿using Castle.Windsor;
using Castle.Windsor.Installer;
using System.Web.Mvc;

namespace Rf.Web.Configuration.Container
{
    public static class IocContainer
    {
        private static IWindsorContainer _container;

        public static IWindsorContainer Setup()
        {
            _container = new WindsorContainer().Install(FromAssembly.This());

            WindsorControllerFactory controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);

            return _container;
        }
    }
}