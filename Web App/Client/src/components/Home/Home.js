import Aux from "../../hoc/Auxillary";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min";
import "font-awesome/css/font-awesome.min.css";
import Navigation from "./Navigation/Navigation";
import About from "./About/About";
import Services from "./Services/Services";
import ContactUs from "./ContactUs/ContactUs";
import Footer from "./Footer/Footer";
import Welcome from "./Welcome/Welcome";
import "./Home.css";
const Home = () => {
  return (
    <Aux>
      <div className="stickywork">
        <Navigation />
      </div>
      <Welcome />
      <About />
      <Services />
      <ContactUs />
      <Footer />
    </Aux>
  );
};

export default Home;
