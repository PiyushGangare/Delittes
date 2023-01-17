import logo from './logo.svg';
import './App.css';
import Elist from './components/EList'
import Edit from './components/Edit';
import Insert from './components/Insert'
import {BrowserRouter as  Router,Routes,Route } from 'react-router-dom';
function App() {
  return (
    <div className="App">
     <Elist></Elist>
     <Router>
      <Routes>
        <Route path="/" exact element={<Elist/>}></Route>
        <Route path="/edit/:id" element={<Edit/>}></Route>
        <Route path="/insert" element={<Insert/>}></Route>

      </Routes>
     </Router>
    </div>
  );
}

export default App;
