import React, { useState } from 'react';
import './App.css';
import Title from './components/Title';
import Modal from './components/Modal';
import EventList from './components/EventList';


function App() {

  const [showModal, setShowModal] = useState(false);

  const [showEvents, setShowEvents] = useState(true);

  const [events, setEvents] = useState([
    { title: "React Training at PeopleCert-Athens", id: 1 },
    { title: "Spring Boot Traing at PeopleCert-Patra", id: 2 },
    { title: "Javascript Fundamentals at PeopleCert-Athens", id: 3 }
  ])

  const handleClose = () => {
    setShowModal(false);
  }

  const handleClick = (id) => {
    setEvents((preEvents) => {
      return preEvents.filter((e) => {
        return id !== e.id;

      })
    })
  }
  const title = "PeopleCert Training Events";
  const subtitle = "All the latest events at PeopleCert";
  return (
    <div className="App">
      <Title title={title} subtitle={subtitle} />
      {showEvents && (
        <div>
          <button onClick={() => { setShowEvents(false) }}>Hide Events</button>
        </div>
      )}

      {!showEvents && (
        <div>
          <button onClick={() => { setShowEvents(true) }}>Show Events</button>
        </div>
      )}

      {showEvents && <EventList events={events} handleClick={handleClick}/>}

      {showModal && (<Modal handleClose={handleClose} isSalesModal={true}>
        <h2>Early Registration is now open for React Training</h2>
        <p>Send us an email to reserve your seat today!</p>
        <a href='#'>Find out more...</a>
      </Modal>)}
      <br /><br /><br /><br />
      <div>
        <button onClick={() => { setShowModal(true) }}>Show More</button>
      </div>
    </div>
  );
}

export default App;
