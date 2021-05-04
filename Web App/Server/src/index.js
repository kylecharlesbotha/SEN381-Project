const express = require("express");
const morgan = require("morgan");
const helmet = require("helmet");
const cors = require("cors");
const errorHandler = require("./middleware/error");
require("dotenv").config({ path: __dirname + "/../.env" });
const port = process.env.PORT || 3001;

const app = express();
app.use(cors());
app.use(morgan("dev"));
app.use(helmet());
app.use(express.json());

app.use("/api/auth", require("./routes/auth"));
app.use("/api/private", require("./routes/private"));
app.use(errorHandler); 

  //Error
app.use((error, req, res, next) => {
    if (error.status) {
      res.status(error.status);
    } else {
      res.status(500);
    }
    const stack = process.env.NODE_ENV === "production" ? error.stack : "🌌";
    res.json({
      message: error.message,
      stack,
    });
});
  
const server = app.listen(port, () => {
    console.log(`Listening on http://localhost:${port}`);
});

process.on("unhandledRejection", (err,promise) => {
  console.log(`Logged error: ${err}`);
  server.close(() => process.exit(1));
})