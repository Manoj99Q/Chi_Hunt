using UnityEngine ;
using EasyUI.PickerWheelUI ;
using UnityEngine.UI ;

public class Demo : MonoBehaviour {
   [SerializeField] private Button uiSpinButton ;
   [SerializeField] private Text uiSpinButtonText ;

   [SerializeField] private PickerWheel pickerWheel ;
    
    public GameObject Congrats, Sorry,Wheel;


    private void Start () {
      uiSpinButton.onClick.AddListener (() => {

         uiSpinButton.interactable = false ;
         uiSpinButtonText.text = "Spinning" ;

         pickerWheel.OnSpinEnd (wheelPiece => {
             Wheel.SetActive(false);
             Debug.Log (
               @" <b>Index:</b> " + wheelPiece.Index + "           <b>Label:</b> " + wheelPiece.Label
               + "\n <b>Amount:</b> " + wheelPiece.Amount + "      <b>Chance:</b> " + wheelPiece.Chance + "%"
            ) ;
             if(wheelPiece.Label!="0")
             {
                 Congrats.SetActive(true);
                 Congrats.transform.GetChild(2).GetComponent<TMPro.TextMeshProUGUI>().text = wheelPiece.Label;
                 Debug.Log(Congrats.transform.GetChild(2).GetComponent<Text>().text);
             }
             else
             {
                 Sorry.SetActive(true);
             }
             
         }) ;

         pickerWheel.Spin () ;

      }) ;

   }

}
