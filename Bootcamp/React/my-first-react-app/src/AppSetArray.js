import { useState } from 'react';
import './App.css';

function App() {



  const [events, setEvents] = useState([
    { title: "React Training at PeopleCert-Athens", id: 1 },
    { title: "Spring Boot Traing at PeopleCert-Patra", id: 2 },
    { title: "Javascript Fundamentals at PeopleCert-Athens", id: 3 }
  ])

  // const handleClick = (id) => {
  //   setEvents(events.filter((e) => {
  //     return id !== e.id;
  //   }))
  // }

  const handleClick = (id) => {
    setEvents((preEvents) => {
      return preEvents.filter((e) => {
        return id !== e.id;

      })
    })
  }

  return (
    <div className="App">
      <h1>My React App</h1>

      {events.map((e, index) => (
        <div key={e.id}>
          <h2>{index + 1} - {e.title}</h2>
          <button onClick={() => { handleClick(e.id); }}>Delete Event</button>
        </div>
      )
      )}
    </div>
  );
}

export default App;
