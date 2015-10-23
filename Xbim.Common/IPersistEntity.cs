// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;

namespace Xbim.Common
{
	public interface IPersistEntity : IPersist
	{
		int EntityLabel {get; }
		IModel Model { get; }
		ActivationStatus ActivationStatus { get; }
		void Activate (bool write);
		void Activate (Action activation);

		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
		IModel ModelOf { get; }
	}

	public enum ActivationStatus : byte
    {
        NotActivated = 0,
        ActivatedRead = 1,
        ActivatedReadWrite = 2
    }

}