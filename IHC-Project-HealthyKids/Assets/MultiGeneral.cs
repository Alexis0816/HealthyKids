using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Multi : MonoBehaviour
{
    // TARGETS
    public GameObject ATarget;
    public GameObject BTarget;
    public GameObject CTarget;
    public GameObject DTarget;
    public GameObject ETarget;
    public GameObject FTarget;
    public GameObject GTarget;
    public GameObject HTarget;
    public GameObject ITarget;
    public GameObject JTarget;
    public GameObject KTarget;
    public GameObject LTarget;
    public GameObject MTarget;
    public GameObject NTarget;
    public GameObject OTarget;
    public GameObject PTarget;
    public GameObject QTarget;
    public GameObject RTarget;
    public GameObject STarget;
    public GameObject TTarget;
    public GameObject UTarget;
    public GameObject VTarget;
    public GameObject WTarget;
    public GameObject XTarget;
    public GameObject YTarget;
    public GameObject ZTarget;

    // VIDEOS
    public GameObject AVideo;
    public GameObject BVideo;
    public GameObject CVideo;
    public GameObject DVideo;
    public GameObject EVideo;
    public GameObject FVideo;
    public GameObject GVideo;
    public GameObject HVideo;
    public GameObject IVideo;
    public GameObject JVideo;
    public GameObject KVideo;
    public GameObject LVideo;
    public GameObject MVideo;
    public GameObject NVideo;
    public GameObject OVideo;
    public GameObject PVideo;
    public GameObject QVideo;
    public GameObject RVideo;
    public GameObject SVideo;
    public GameObject TVideo;
    public GameObject UVideo;
    public GameObject VVideo;
    public GameObject WVideo;
    public GameObject XVideo;
    public GameObject YVideo;
    public GameObject ZVideo;

    // ObserverBehaviours
    private ObserverBehaviour aObserverBehaviour;
    private ObserverBehaviour bObserverBehaviour;
    private ObserverBehaviour cObserverBehaviour;
    private ObserverBehaviour dObserverBehaviour;
    private ObserverBehaviour eObserverBehaviour;
    private ObserverBehaviour fObserverBehaviour;
    private ObserverBehaviour gObserverBehaviour;
    private ObserverBehaviour hObserverBehaviour;
    private ObserverBehaviour iObserverBehaviour;
    private ObserverBehaviour jObserverBehaviour;
    private ObserverBehaviour kObserverBehaviour;
    private ObserverBehaviour lObserverBehaviour;
    private ObserverBehaviour mObserverBehaviour;
    private ObserverBehaviour nObserverBehaviour;
    private ObserverBehaviour oObserverBehaviour;
    private ObserverBehaviour pObserverBehaviour;
    private ObserverBehaviour qObserverBehaviour;
    private ObserverBehaviour rObserverBehaviour;
    private ObserverBehaviour sObserverBehaviour;
    private ObserverBehaviour tObserverBehaviour;
    private ObserverBehaviour uObserverBehaviour;
    private ObserverBehaviour vObserverBehaviour;
    private ObserverBehaviour wObserverBehaviour;
    private ObserverBehaviour xObserverBehaviour;
    private ObserverBehaviour yObserverBehaviour;
    private ObserverBehaviour zObserverBehaviour;

    void Start()
    {
        // Obtener los ObserverBehaviour de cada target
        aObserverBehaviour = ATarget.GetComponent<ObserverBehaviour>();
        bObserverBehaviour = BTarget.GetComponent<ObserverBehaviour>();
        cObserverBehaviour = CTarget.GetComponent<ObserverBehaviour>();
        dObserverBehaviour = DTarget.GetComponent<ObserverBehaviour>();
        eObserverBehaviour = ETarget.GetComponent<ObserverBehaviour>();
        fObserverBehaviour = FTarget.GetComponent<ObserverBehaviour>();
        gObserverBehaviour = GTarget.GetComponent<ObserverBehaviour>();
        hObserverBehaviour = HTarget.GetComponent<ObserverBehaviour>();
        iObserverBehaviour = ITarget.GetComponent<ObserverBehaviour>();
        jObserverBehaviour = JTarget.GetComponent<ObserverBehaviour>();
        kObserverBehaviour = KTarget.GetComponent<ObserverBehaviour>();
        lObserverBehaviour = LTarget.GetComponent<ObserverBehaviour>();
        mObserverBehaviour = MTarget.GetComponent<ObserverBehaviour>();
        nObserverBehaviour = NTarget.GetComponent<ObserverBehaviour>();
        oObserverBehaviour = OTarget.GetComponent<ObserverBehaviour>();
        pObserverBehaviour = PTarget.GetComponent<ObserverBehaviour>();
        qObserverBehaviour = QTarget.GetComponent<ObserverBehaviour>();
        rObserverBehaviour = RTarget.GetComponent<ObserverBehaviour>();
        sObserverBehaviour = STarget.GetComponent<ObserverBehaviour>();
        tObserverBehaviour = TTarget.GetComponent<ObserverBehaviour>();
        uObserverBehaviour = UTarget.GetComponent<ObserverBehaviour>();
        vObserverBehaviour = VTarget.GetComponent<ObserverBehaviour>();
        wObserverBehaviour = WTarget.GetComponent<ObserverBehaviour>();
        xObserverBehaviour = XTarget.GetComponent<ObserverBehaviour>();
        yObserverBehaviour = YTarget.GetComponent<ObserverBehaviour>();
        zObserverBehaviour = ZTarget.GetComponent<ObserverBehaviour>();

        // Esconder los videos al inicio
        AVideo.SetActive(false);
        BVideo.SetActive(false);
        CVideo.SetActive(false);
        DVideo.SetActive(false);
        EVideo.SetActive(false);
        FVideo.SetActive(false);
        GVideo.SetActive(false);
        HVideo.SetActive(false);
        IVideo.SetActive(false);
        JVideo.SetActive(false);
        KVideo.SetActive(false);
        LVideo.SetActive(false);
        MVideo.SetActive(false);
        NVideo.SetActive(false);
        OVideo.SetActive(false);
        PVideo.SetActive(false);
        QVideo.SetActive(false);
        RVideo.SetActive(false);
        SVideo.SetActive(false);
        TVideo.SetActive(false);
        UVideo.SetActive(false);
        VVideo.SetActive(false);
        WVideo.SetActive(false);
        XVideo.SetActive(false);
        YVideo.SetActive(false);
        ZVideo.SetActive(false);

        // Asignar los métodos de callback para los eventos de tracking
        if (aObserverBehaviour)
            aObserverBehaviour.OnTargetStatusChanged += OnATargetStatusChanged;

        if (bObserverBehaviour)
            bObserverBehaviour.OnTargetStatusChanged += OnBTargetStatusChanged;

        if (cObserverBehaviour)
            cObserverBehaviour.OnTargetStatusChanged += OnCTargetStatusChanged;

        if (dObserverBehaviour)
            dObserverBehaviour.OnTargetStatusChanged += OnDTargetStatusChanged;

        if (eObserverBehaviour)
            eObserverBehaviour.OnTargetStatusChanged += OnETargetStatusChanged;

        if (fObserverBehaviour)
            fObserverBehaviour.OnTargetStatusChanged += OnFTargetStatusChanged;

        if (gObserverBehaviour)
            gObserverBehaviour.OnTargetStatusChanged += OnGTargetStatusChanged;

        if (hObserverBehaviour)
            hObserverBehaviour.OnTargetStatusChanged += OnHTargetStatusChanged;

        if (iObserverBehaviour)
            iObserverBehaviour.OnTargetStatusChanged += OnITargetStatusChanged;

        if (jObserverBehaviour)
            jObserverBehaviour.OnTargetStatusChanged += OnJTargetStatusChanged;

        if (kObserverBehaviour)
            kObserverBehaviour.OnTargetStatusChanged += OnKTargetStatusChanged;

        if (lObserverBehaviour)
            lObserverBehaviour.OnTargetStatusChanged += OnLTargetStatusChanged;

        if (mObserverBehaviour)
            mObserverBehaviour.OnTargetStatusChanged += OnMTargetStatusChanged;

        if (nObserverBehaviour)
            nObserverBehaviour.OnTargetStatusChanged += OnNTargetStatusChanged;

        if (oObserverBehaviour)
            oObserverBehaviour.OnTargetStatusChanged += OnOTargetStatusChanged;

        if (pObserverBehaviour)
            pObserverBehaviour.OnTargetStatusChanged += OnPTargetStatusChanged;

        if (qObserverBehaviour)
            qObserverBehaviour.OnTargetStatusChanged += OnQTargetStatusChanged;

        if (rObserverBehaviour)
            rObserverBehaviour.OnTargetStatusChanged += OnRTargetStatusChanged;

        if (sObserverBehaviour)
            sObserverBehaviour.OnTargetStatusChanged += OnSTargetStatusChanged;

        if (tObserverBehaviour)
            tObserverBehaviour.OnTargetStatusChanged += OnTTargetStatusChanged;

        if (uObserverBehaviour)
            uObserverBehaviour.OnTargetStatusChanged += OnUTargetStatusChanged;

        if (vObserverBehaviour)
            vObserverBehaviour.OnTargetStatusChanged += OnVTargetStatusChanged;

        if (wObserverBehaviour)
            wObserverBehaviour.OnTargetStatusChanged += OnWTargetStatusChanged;

        if (xObserverBehaviour)
            xObserverBehaviour.OnTargetStatusChanged += OnXTargetStatusChanged;

        if (yObserverBehaviour)
            yObserverBehaviour.OnTargetStatusChanged += OnYTargetStatusChanged;

        if (zObserverBehaviour)
            zObserverBehaviour.OnTargetStatusChanged += OnZTargetStatusChanged;
    }

    void OnDestroy()
    {
        // Desregistrar los métodos de callback para evitar memory leaks
        if (aObserverBehaviour)
            aObserverBehaviour.OnTargetStatusChanged -= OnATargetStatusChanged;

        if (bObserverBehaviour)
            bObserverBehaviour.OnTargetStatusChanged -= OnBTargetStatusChanged;

        if (cObserverBehaviour)
            cObserverBehaviour.OnTargetStatusChanged -= OnCTargetStatusChanged;

        if (dObserverBehaviour)
            dObserverBehaviour.OnTargetStatusChanged -= OnDTargetStatusChanged;

        if (eObserverBehaviour)
            eObserverBehaviour.OnTargetStatusChanged -= OnETargetStatusChanged;

        if (fObserverBehaviour)
            fObserverBehaviour.OnTargetStatusChanged -= OnFTargetStatusChanged;

        if (gObserverBehaviour)
            gObserverBehaviour.OnTargetStatusChanged -= OnGTargetStatusChanged;

        if (hObserverBehaviour)
            hObserverBehaviour.OnTargetStatusChanged -= OnHTargetStatusChanged;

        if (iObserverBehaviour)
            iObserverBehaviour.OnTargetStatusChanged -= OnITargetStatusChanged;

        if (jObserverBehaviour)
            jObserverBehaviour.OnTargetStatusChanged -= OnJTargetStatusChanged;

        if (kObserverBehaviour)
            kObserverBehaviour.OnTargetStatusChanged -= OnKTargetStatusChanged;

        if (lObserverBehaviour)
            lObserverBehaviour.OnTargetStatusChanged -= OnLTargetStatusChanged;

        if (mObserverBehaviour)
            mObserverBehaviour.OnTargetStatusChanged -= OnMTargetStatusChanged;

        if (nObserverBehaviour)
            nObserverBehaviour.OnTargetStatusChanged -= OnNTargetStatusChanged;

        if (oObserverBehaviour)
            oObserverBehaviour.OnTargetStatusChanged -= OnOTargetStatusChanged;

        if (pObserverBehaviour)
            pObserverBehaviour.OnTargetStatusChanged -= OnPTargetStatusChanged;

        if (qObserverBehaviour)
            qObserverBehaviour.OnTargetStatusChanged -= OnQTargetStatusChanged;

        if (rObserverBehaviour)
            rObserverBehaviour.OnTargetStatusChanged -= OnRTargetStatusChanged;

        if (sObserverBehaviour)
            sObserverBehaviour.OnTargetStatusChanged -= OnSTargetStatusChanged;

        if (tObserverBehaviour)
            tObserverBehaviour.OnTargetStatusChanged -= OnTTargetStatusChanged;

        if (uObserverBehaviour)
            uObserverBehaviour.OnTargetStatusChanged -= OnUTargetStatusChanged;

        if (vObserverBehaviour)
            vObserverBehaviour.OnTargetStatusChanged -= OnVTargetStatusChanged;

        if (wObserverBehaviour)
            wObserverBehaviour.OnTargetStatusChanged -= OnWTargetStatusChanged;

        if (xObserverBehaviour)
            xObserverBehaviour.OnTargetStatusChanged -= OnXTargetStatusChanged;

        if (yObserverBehaviour)
            yObserverBehaviour.OnTargetStatusChanged -= OnYTargetStatusChanged;

        if (zObserverBehaviour)
            zObserverBehaviour.OnTargetStatusChanged -= OnZTargetStatusChanged;
    }

    // Métodos para cada letra del abecedario

    private void OnATargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            AVideo.SetActive(true);
            HideAllOtherVideos("A");
        }
        else
        {
            AVideo.SetActive(false);
        }
    }

    private void OnBTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            BVideo.SetActive(true);
            HideAllOtherVideos("B");
        }
        else
        {
            BVideo.SetActive(false);
        }
    }

    private void OnCTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            CVideo.SetActive(true);
            HideAllOtherVideos("C");
        }
        else
        {
            CVideo.SetActive(false);
        }
    }

    private void OnDTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            DVideo.SetActive(true);
            HideAllOtherVideos("D");
        }
        else
        {
            DVideo.SetActive(false);
        }
    }

    private void OnETargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            EVideo.SetActive(true);
            HideAllOtherVideos("E");
        }
        else
        {
            EVideo.SetActive(false);
        }
    }

    private void OnFTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            FVideo.SetActive(true);
            HideAllOtherVideos("F");
        }
        else
        {
            FVideo.SetActive(false);
        }
    }

    private void OnGTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            GVideo.SetActive(true);
            HideAllOtherVideos("G");
        }
        else
        {
            GVideo.SetActive(false);
        }
    }

    private void OnHTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            HVideo.SetActive(true);
            HideAllOtherVideos("H");
        }
        else
        {
            HVideo.SetActive(false);
        }
    }

    private void OnITargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            IVideo.SetActive(true);
            HideAllOtherVideos("I");
        }
        else
        {
            IVideo.SetActive(false);
        }
    }

    private void OnJTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            JVideo.SetActive(true);
            HideAllOtherVideos("J");
        }
        else
        {
            JVideo.SetActive(false);
        }
    }

    private void OnKTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            KVideo.SetActive(true);
            HideAllOtherVideos("K");
        }
        else
        {
            KVideo.SetActive(false);
        }
    }

    private void OnLTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            LVideo.SetActive(true);
            HideAllOtherVideos("L");
        }
        else
        {
            LVideo.SetActive(false);
        }
    }

    private void OnMTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            MVideo.SetActive(true);
            HideAllOtherVideos("M");
        }
        else
        {
            MVideo.SetActive(false);
        }
    }

    private void OnNTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            NVideo.SetActive(true);
            HideAllOtherVideos("N");
        }
        else
        {
            NVideo.SetActive(false);
        }
    }

    private void OnOTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            OVideo.SetActive(true);
            HideAllOtherVideos("O");
        }
        else
        {
            OVideo.SetActive(false);
        }
    }

    private void OnPTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            PVideo.SetActive(true);
            HideAllOtherVideos("P");
        }
        else
        {
            PVideo.SetActive(false);
        }
    }

    private void OnQTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            QVideo.SetActive(true);
            HideAllOtherVideos("Q");
        }
        else
        {
            QVideo.SetActive(false);
        }
    }

    private void OnRTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            RVideo.SetActive(true);
            HideAllOtherVideos("R");
        }
        else
        {
            RVideo.SetActive(false);
        }
    }

    private void OnSTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            SVideo.SetActive(true);
            HideAllOtherVideos("S");
        }
        else
        {
            SVideo.SetActive(false);
        }
    }

    private void OnTTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            TVideo.SetActive(true);
            HideAllOtherVideos("T");
        }
        else
        {
            TVideo.SetActive(false);
        }
    }

    private void OnUTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            UVideo.SetActive(true);
            HideAllOtherVideos("U");
        }
        else
        {
            UVideo.SetActive(false);
        }
    }

    private void OnVTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            VVideo.SetActive(true);
            HideAllOtherVideos("V");
        }
        else
        {
            VVideo.SetActive(false);
        }
    }

    private void OnWTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            WVideo.SetActive(true);
            HideAllOtherVideos("W");
        }
        else
        {
            WVideo.SetActive(false);
        }
    }

    private void OnXTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            XVideo.SetActive(true);
            HideAllOtherVideos("X");
        }
        else
        {
            XVideo.SetActive(false);
        }
    }

    private void OnYTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            YVideo.SetActive(true);
            HideAllOtherVideos("Y");
        }
        else
        {
            YVideo.SetActive(false);
        }
    }

    private void OnZTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            ZVideo.SetActive(true);
            HideAllOtherVideos("Z");
        }
        else
        {
            ZVideo.SetActive(false);
        }
    }

    // Método para esconder todos los videos excepto el de la letra actual
    private void HideAllOtherVideos(string currentLetter)
    {
        if (currentLetter != "A") AVideo.SetActive(false);
        if (currentLetter != "B") BVideo.SetActive(false);
        if (currentLetter != "C") CVideo.SetActive(false);
        if (currentLetter != "D") DVideo.SetActive(false);
        if (currentLetter != "E") EVideo.SetActive(false);
        if (currentLetter != "F") FVideo.SetActive(false);
        if (currentLetter != "G") GVideo.SetActive(false);
        if (currentLetter != "H") HVideo.SetActive(false);
        if (currentLetter != "I") IVideo.SetActive(false);
        if (currentLetter != "J") JVideo.SetActive(false);
        if (currentLetter != "K") KVideo.SetActive(false);
        if (currentLetter != "L") LVideo.SetActive(false);
        if (currentLetter != "M") MVideo.SetActive(false);
        if (currentLetter != "N") NVideo.SetActive(false);
        if (currentLetter != "O") OVideo.SetActive(false);
        if (currentLetter != "P") PVideo.SetActive(false);
        if (currentLetter != "Q") QVideo.SetActive(false);
        if (currentLetter != "R") RVideo.SetActive(false);
        if (currentLetter != "S") SVideo.SetActive(false);
        if (currentLetter != "T") TVideo.SetActive(false);
        if (currentLetter != "U") UVideo.SetActive(false);
        if (currentLetter != "V") VVideo.SetActive(false);
        if (currentLetter != "W") WVideo.SetActive(false);
        if (currentLetter != "X") XVideo.SetActive(false);
        if (currentLetter != "Y") YVideo.SetActive(false);
        if (currentLetter != "Z") ZVideo.SetActive(false);
    }
}