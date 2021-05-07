import Aux from "../../../hoc/Auxillary";
import "./Welcome.css";
import Img from "../../../assets/images/banner-right-image.png";

const Welcome = () => {
  return (
    <Aux>
      <div id="welcome"></div>
      <div className="welcome container">
        <div className="row">
          <div className="col-md-6 text-center">
            <h5>WELCOME TO PREMIER SERVICE SOLUTIONS</h5>
            <h2>Here at PSS we make your dreams come true </h2>
            <p>some randomw text here that still has to be completed and filled and who knows what but hey we just here living. LEEEEEEKKKKKKKKKEKEEEEEERRRRRRRR</p>
          </div>
          <div className="col-md-6 text-center">
            <div className="welcomeimagcon">
              <img src={Img} alt="Welcome" className="helpdesk" />
            </div>
          </div>
        </div>
      </div>
    </Aux>
  );
};

export default Welcome;
