using System.Collections;
using System.Collections.Generic;

//Se supone que de aquí heredan todos los trackers (uno por cada tipo de evento)
interface ITrackerAsset
{
    //Solo acepta el evento si es de su tipo
    bool Accept(RatEvent e);
}

//class ShootTracker : TrackerAsset
