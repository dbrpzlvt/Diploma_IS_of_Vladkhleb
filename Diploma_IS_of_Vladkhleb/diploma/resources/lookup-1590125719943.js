(function(window, undefined) {
  var dictionary = {
    "d4fc0f93-6adb-4cd1-9565-4e0bf0ffc265": "Paker",
    "a76f9ed3-aacc-4563-bd25-3094674a4626": "Administrator",
    "e74a3ab6-2d6a-444a-a95b-312067c23a2b": "Сonfectioner",
    "c2864a6a-88db-4ab4-93c6-edcdfa7ba455": "Main_technologist",
    "4d75eb93-2350-40d4-a204-10c40087dd63": "Baker",
    "18d1fb38-d7bd-410c-82a0-b7ba72b905c3": "Lab",
    "e3480c4d-d62a-4501-9eaa-33f66cc27fbe": "Authorisation",
    "f9ba71eb-f5d5-4396-9c76-f71c13d506ce": "Lab_chemist_technologist",
    "d12245cc-1680-458d-89dd-4f0d7fb22724": "Enterance",
    "b08d8c20-596a-4bd6-9d9b-f06007eef8d3": "Main_page",
    "f43914c2-89dc-4103-a5a6-e2697423502c": "Forwarding_driver",
    "c5f3b828-534c-4bf4-a314-5600c566d2f9": "Technologist",
    "f1e4afc0-ba64-4b1e-8a44-8faa122db789": "Stockman",
    "e73b655d-d3ec-4dcc-a55c-6e0293422bde": "960 grid - 16 columns",
    "ef07b413-721c-418e-81b1-33a7ed533245": "960 grid - 12 columns",
    "f39803f7-df02-4169-93eb-7547fb8c961a": "Template 1",
    "bb8abf58-f55e-472d-af05-a7d1bb0cc014": "default"
  };

  var uriRE = /^(\/#)?(screens|templates|masters|scenarios)\/(.*)(\.html)?/;
  window.lookUpURL = function(fragment) {
    var matches = uriRE.exec(fragment || "") || [],
        folder = matches[2] || "",
        canvas = matches[3] || "",
        name, url;
    if(dictionary.hasOwnProperty(canvas)) { /* search by name */
      url = folder + "/" + canvas;
    }
    return url;
  };

  window.lookUpName = function(fragment) {
    var matches = uriRE.exec(fragment || "") || [],
        folder = matches[2] || "",
        canvas = matches[3] || "",
        name, canvasName;
    if(dictionary.hasOwnProperty(canvas)) { /* search by name */
      canvasName = dictionary[canvas];
    }
    return canvasName;
  };
})(window);