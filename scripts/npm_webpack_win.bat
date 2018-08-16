cd ../src/FilterLists.Web
call npm install
call npx webpack --config webpack.config.vendor.js
call npx webpack --config webpack.config.js
PAUSE