import Aux from "../../hoc/Auxillary";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min";
import "font-awesome/css/font-awesome.min.css";
import Navigation from "./Navigation/Navigation";
import About from "./About/About";
import ContactUs from "./ContactUs/ContactUs";
const Home = () => {
  return (
    <Aux>
      <Navigation />
      <About />
      <ContactUs />
    </Aux>
  );
};

export default Home;
