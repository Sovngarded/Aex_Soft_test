const { createProxyMiddleware } = require("http-proxy-middleware");

module.exports = function (app) {
  app.use(
    ["/api", "/api/movies"],
    createProxyMiddleware({
      target: "https://localhost:5001",
    })
  );
};