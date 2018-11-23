using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BansheeEngine
{
	/** @addtogroup Particles
	 *  @{
	 */

	/// <summary>
	/// Moves particles so that their sprites orbit their center according to the provided offset and rotation values.
	/// </summary>
	public partial class ParticleOrbit : ParticleEvolver
	{
		private ParticleOrbit(bool __dummy0) { }
		protected ParticleOrbit() { }

		/// <summary>Options describing the evolver.</summary>
		public ParticleOrbitOptions Options
		{
			get
			{
				ParticleOrbitOptions temp;
				Internal_getOptions(mCachedPtr, out temp);
				return temp;
			}
			set { Internal_setOptions(mCachedPtr, ref value); }
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setOptions(IntPtr thisPtr, ref ParticleOrbitOptions options);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_getOptions(IntPtr thisPtr, out ParticleOrbitOptions __output);
	}

	/** @} */
}