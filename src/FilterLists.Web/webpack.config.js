const path = require("path");
const webpack = require("webpack");
const ExtractTextPlugin = require("extract-text-webpack-plugin");
const CheckerPlugin = require("awesome-typescript-loader").CheckerPlugin;
const bundleOutputDir = "./wwwroot/dist";
const PurifyCSSPlugin = require("purifycss-webpack");

module.exports = (env) => {
    const isDevBuild = !(env && env.prod);
    return [
        {
            stats: { modules: false },
            entry: { 'main': "./ClientApp/boot.tsx" },
            resolve: { extensions: [".js", ".jsx", ".ts", ".tsx"] },
            output: {
                path: path.join(__dirname, bundleOutputDir),
                filename: "[name].js",
                publicPath: "dist/"
            },
            module: {
                rules: [
                    { test: /\.tsx?$/, include: /ClientApp/, use: "awesome-typescript-loader?silent=true" },
                    {
                        test: /\.css$/,
                        use: isDevBuild
                            ? ["style-loader", "css-loader"]
                            : ExtractTextPlugin.extract({
                                use: [
                                    {
                                        loader: "css-loader",
                                        options: {
                                            minimize: { discardComments: { removeAll: true } }
                                        }
                                    }
                                ]
                            })
                    },
                    { test: /\.(png|jpg|jpeg|gif|svg)$/, use: "url-loader?limit=25000" }
                ]
            },
            plugins: [
                new CheckerPlugin(),
                new webpack.DllReferencePlugin({
                    context: __dirname,
                    manifest: require("./wwwroot/dist/vendor-manifest.json")
                })
            ].concat(isDevBuild
                ? [
                    new webpack.SourceMapDevToolPlugin({
                        filename: "[file].map",
                        moduleFilenameTemplate:
                            path.relative(bundleOutputDir,
                                "[resourcePath]")
                    })
                ]
                : [
                    new webpack.optimize.UglifyJsPlugin({
                        output: {
                            comments: false
                        }
                    }),
                    new ExtractTextPlugin("site.css"),
                    new ExtractTextPlugin("vendor.css"),
                    new PurifyCSSPlugin({
                        paths: globAll.sync([
                            path.join(__dirname, "dist/*.html"),
                            path.join(__dirname, "src/**/*.js")
                        ]),
                        moduleExtensions: [".js"]
                    })
                ])
        }
    ];
};