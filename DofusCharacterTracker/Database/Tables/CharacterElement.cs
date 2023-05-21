﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DofusCharacterTracker.Database.Tables;

public sealed class CharacterElement: IDbTable
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public required Guid CharacterId { get; set; }
    public Character? Character { get; set; }

    public Element Element { get; set; }

    public class Configuration : IEntityTypeConfiguration<CharacterElement>
    {
        public void Configure(EntityTypeBuilder<CharacterElement> builder)
        {
            builder.Property(x => x.Element).HasConversion<string>().HasMaxLength(50);
        }
    }
}

public enum Element
{
    Strength,
    Agility,
    Intelligence,
    Chance,
}