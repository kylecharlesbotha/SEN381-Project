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
            <p>
              We’re an IT consulting company offering customized technical
              support, planning and maintenance to businesses, non-profits, home
              users and sole proprietors. PSS provides IT support and security
              solutions across most regions in South-Africa. Let us help you
              gain control of your Information Technology infrastructure and
              security so you can focus on running your company.Once you
              experience our stellar service and awesome technical know-how, you
              might just sleep better, breathe easier, and walk with a new
              spring in your step.If not, we’ll try even harder! Whether you
              have a single frustrated user with a computer issue, or your
              entire network is down, count on PSS to recover, restore, and
              repair the damage in the shortest possible time. We have a solid
              track-record and over 5 hundred thousand tickets completed in the
              IT industry.
            </p>
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
