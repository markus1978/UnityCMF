using System;
using UnityCMF.ECore;

namespace UnityCMF.CCore
{
	public interface CFactory
	{
		CPackage PackageInstance { get; }
		CObject create(EClass eClass);
	}
}

