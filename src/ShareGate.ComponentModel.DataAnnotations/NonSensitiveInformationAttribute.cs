using System;

namespace ShareGate.ComponentModel.DataAnnotations;

/// <summary>
/// Indicates that a property does not contains sensitive information.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class NonSensitiveInformationAttribute : Attribute
{
}