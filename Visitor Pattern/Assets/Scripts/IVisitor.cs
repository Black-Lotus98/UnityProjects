using UnityEngine;
public interface IVisitor
{
    void Visit(BikeShield aBikeShield);
    void Visit(BikeEngin aBikeEngin);
    void Visit(BikeWeapon aBikeWeapon);
}