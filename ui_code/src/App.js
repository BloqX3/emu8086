import AceEditor from "react-ace";
import "ace-builds/src-noconflict/mode-assembly_x86";
import "ace-builds/src-noconflict/theme-monokai";
import "ace-builds/src-noconflict/ext-language_tools";
import "ace-builds/src-noconflict/ext-inline_autocomplete";

function onChange(newValue) {
  console.log("CODE_FLAG" + newValue);
}
function App() {
  return (
    <div className="App">
      <AceEditor style={{width:"100%", height:"100vh"}}
                 onChange ={onChange}
                 mode="assembly_x86"
                 theme="monokai"
                 name="EDITOR"
                  setOptions={{
                    enableBasicAutocompletion: true,
                    enableLiveAutocompletion: true,
                    enableSnippets: true,
                    showLineNumbers: true,
                    tabSize: 4,
                    fontSize: "14pt",
                    showPrintMargin: false,
                    highlightActiveLine: true,
                    highlightGutterLine: true,
                    useSoftTabs: true
                }}
                  editorProps={{
                    $blockScrolling: true,
                    $highlightPending: true,
                    $highlightTagPending: true,
                  }}/>
    </div>
  );
}

export default App;
