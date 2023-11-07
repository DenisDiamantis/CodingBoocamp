import './App.css'
import { BrowserRouter, Route, Routes, Link } from "react-router-dom";
import Home from './pages/Home';
import Contact from './pages/Contact';
import About from './pages/About';


export default function App() {

  return (

    <div className="App">
      <BrowserRouter>

        <nav>
          <Link to="/">Home</Link>
          <Link to="/about">About</Link>
          <Link to="/contact">Contact</Link>
        </nav>
        <h1>My Articles</h1>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/about" element={<About />} />
          <Route path="/contact" element={<Contact />} />
        </Routes>

      </BrowserRouter>
    </div>
  );
}
