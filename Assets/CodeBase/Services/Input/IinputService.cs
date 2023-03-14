using UnityEngine;

namespace CodeBase.Services.Input
{
    public interface IinputService
    {
        Vector2 Axis { get; }

        bool IsAttackButtonUp();
    }
}