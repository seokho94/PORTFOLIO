using UnityEngine;

public class Light_Cycle : MonoBehaviour
{
    [SerializeField] private GameObject obj_PurpCrystal;
    [SerializeField] private GameObject obj_BlueCrystal;
    [SerializeField] private GameObject obj_Gemstone;
    [SerializeField] private GameObject obj_LightBox;
    private bool isLight;
    public float delayT;
    public float repeatT;
    public float[] max_intensity;
    public Light[] Light_Controll;
    private float[] red;
    private float[] blue;
    private float[] green;
    // Start is called before the first frame update
    void Start()
    {
        Light_Controll = GetComponentsInChildren<Light>();
        Insert_Intensity();
        Insert_RGB();
        InvokeRepeating("InvokeLight", delayT, repeatT);
    }

    //max_intensity 값 설정
    void Insert_Intensity()
    {
        max_intensity = new float[Light_Controll.Length];
        Debug.Log(Light_Controll.Length);
        for(int n = 0; n < Light_Controll.Length; n++)
        {
            max_intensity[n] = Light_Controll[n].intensity;
        }
    }

    void Insert_RGB()
    {
        red = new float[3];
        blue = new float[3];
        green = new float[3];
        
    }

    //밤 낮 시스템
    void InvokeLight()
    {
        if (isLight == true)
        {
            if (Light_Controll[0].intensity > 0f)
            {
                Sinking_Light();
            }
            else
            {
                isLight = false;
            }
        }
        else
        {
            if (Light_Controll[0].intensity < max_intensity[0])
            {
                Rising_Light();
            }
            else
            {
                isLight = true;
            }
        }
    }

    //intensity 값 계단식 증가
    void Rising_Light()
    {
        for (int x = 0; x < Light_Controll.Length; x++)
        {
            Light_Controll[x].intensity = Light_Controll[x].intensity + (max_intensity[x] / repeatT);
        }
    }

    //intensity 값 계단식 감소
    void Sinking_Light()
    {
        for (int x = 0; x < Light_Controll.Length; x++)
        {
            Light_Controll[x].intensity = Light_Controll[x].intensity - (max_intensity[x] / repeatT);
        }
    }
}
