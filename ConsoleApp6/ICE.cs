using ConsoleApp6.Abstact_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class ICE : Engine
    {
        private float _curtemp=0;
        private bool _isWorking=false;
        public override float EngineTemp => _curtemp;

        public override float MaxTemp => _t;

        public override bool EngineStatus => _isWorking;

        public ICE(float I, List<int> M, List<int> V, float T,float Hm,float Hv,float c)
        {
            _i = I;
            _m = M;
            _v = V;
            _t = T;
            _hm = Hm;
            _hv = Hv;
            _c = c;
    
        }
        public override void Start(float TAir)
        {
            _curtemp = TAir;
            float a;
            float VH;
            float Vc;
            float M;
            float V;
            for (int i = 0; i < _m.Count(); i++)
            {   M = _m[i];
                V = _v[i];

                while (V < _v[i+1])
                {
                    a = M * _i;
                    VH = V * _hm+V*V*_hv;
                    Vc = _c * (TAir - _curtemp);
                    _curtemp += VH - Vc;
                    V += a;
                    M = (V - _v[i]) * (_m[i + 1] - _m[i]) / (_v[i + 1] - _v[i]) + _m[i];
                    if (!_isWorking) return;
                }
            }
        }

        public override void Stop()=>_isWorking = false;
         
        
    }
}
