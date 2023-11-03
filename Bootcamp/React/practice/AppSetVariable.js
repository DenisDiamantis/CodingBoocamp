import { useState } from 'react';
import './App.css';

function App() {


  const [name, setName] = useState('Denis');

  const [events, setEvens] = useState([
    { title: "React Training at PeopleCert-Athens", id: 1 },
    { title: "Spring Boot Traing at PeopleCert-Patra", id: 2 },
    { title: "Javascript Fundamentals at PeopleCert-Athens", id: 3 }
  ])

  const handleClick = () => {
    setName("Michael");
    console.log(name);
  }
  return (
    <div className="App">
      <h1>My React App</h1>
      <h3>My name is {name}</h3>
      <button onClick={handleClick}>Change name</button>

      {events.map((e) => (
        <div key={e.id}>
          <h2>{e.title}</h2>
        </div>
      ))}
    </div>
  );
}

export default App;
