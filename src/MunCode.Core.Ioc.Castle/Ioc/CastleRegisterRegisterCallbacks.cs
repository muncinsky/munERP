﻿namespace MunCode.Core.Ioc
{
    using global::Castle.MicroKernel;
    using global::Castle.MicroKernel.Registration;

    using MunCode.Core.Guards;
    using MunCode.Core.Messaging.Endpoints.Input;

    public class CastleRegisterRegisterCallbacks : IRegisterCallbacks
    {
        private readonly IKernel kernel;

        public CastleRegisterRegisterCallbacks(IKernel kernel)
        {
            Guard.NotNull(kernel, nameof(kernel));
            this.kernel = kernel;
        }

        public ContainerRegisterCallback SingletonRegisterCallback =>
            (s, t, n) => this.kernel.Register(Component.For(s).ImplementedBy(t).LifestyleSingleton().NamedIfNotEmpty(n));

        public ContainerRegisterCallback CallScopeRegisterCallback =>
            (s, t, n) => this.kernel.Register(Component.For(s).ImplementedBy(t).LifestyleScoped().NamedIfNotEmpty(n));
    }
}