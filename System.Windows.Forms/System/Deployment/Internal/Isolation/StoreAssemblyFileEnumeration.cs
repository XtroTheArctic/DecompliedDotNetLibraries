﻿namespace System.Deployment.Internal.Isolation
{
    using System;
    using System.Collections;
    using System.Security;

    internal class StoreAssemblyFileEnumeration : IEnumerator
    {
        private System.Deployment.Internal.Isolation.STORE_ASSEMBLY_FILE _current;
        private System.Deployment.Internal.Isolation.IEnumSTORE_ASSEMBLY_FILE _enum;
        private bool _fValid;

        [SecuritySafeCritical]
        public StoreAssemblyFileEnumeration(System.Deployment.Internal.Isolation.IEnumSTORE_ASSEMBLY_FILE pI)
        {
            this._enum = pI;
        }

        private System.Deployment.Internal.Isolation.STORE_ASSEMBLY_FILE GetCurrent()
        {
            if (!this._fValid)
            {
                throw new InvalidOperationException();
            }
            return this._current;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        [SecuritySafeCritical]
        public bool MoveNext()
        {
            System.Deployment.Internal.Isolation.STORE_ASSEMBLY_FILE[] rgelt = new System.Deployment.Internal.Isolation.STORE_ASSEMBLY_FILE[1];
            uint num = this._enum.Next(1, rgelt);
            if (num == 1)
            {
                this._current = rgelt[0];
            }
            return (this._fValid = num == 1);
        }

        [SecuritySafeCritical]
        public void Reset()
        {
            this._fValid = false;
            this._enum.Reset();
        }

        public System.Deployment.Internal.Isolation.STORE_ASSEMBLY_FILE Current
        {
            get
            {
                return this.GetCurrent();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.GetCurrent();
            }
        }
    }
}

