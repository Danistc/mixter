﻿namespace Mixter.Domain
{
    public struct MessageRepublished : IDomainEvent
    {
        public MessageId Id { get; private set; }
        public UserId Republisher { get; private set; }

        public MessageRepublished(MessageId id, UserId republisher)
            : this()
        {
            Id = id;
            Republisher = republisher;
        }
    }
}