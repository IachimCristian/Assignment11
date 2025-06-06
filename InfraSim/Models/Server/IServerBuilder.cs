using System;
using InfraSim.Models.State;
using InfraSim.Models.Capability;

namespace InfraSim.Models.Server
{
    public interface IServerBuilder
    {
        IServerBuilder WithId(Guid id);
        IServerBuilder WithType(ServerType type);
        IServerBuilder WithCapability(IServerCapability capability);
        IServerBuilder WithState(IServerState state);
        IServerBuilder WithValidator(IValidatorStrategy validator);
        IServer Build();
    }
} 