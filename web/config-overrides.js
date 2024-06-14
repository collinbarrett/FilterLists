const { getThemeVariables } = require("antd/dist/theme");
const {
  override,
  fixBabelImports,
  addLessLoader,
  adjustStyleLoaders,
} = require("customize-cra");

module.exports = override(
  fixBabelImports("import", {
    libraryName: "antd",
    libraryDirectory: "es",
    style: true,
  }),
  addLessLoader({
    lessOptions: {
      javascriptEnabled: true,
      modifyVars: {
        ...getThemeVariables({
          dark: true,
          compact: true,
        }),
      },
    },
  }),
  adjustStyleLoaders(({ use: [, , postcss] }) => {
    const postcssOptions = postcss.options;
    postcss.options = { postcssOptions };
  }),
);
