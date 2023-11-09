<template>
  <h1>{{ title }}</h1>
  <p>Welcome</p>
  <!-- <input type="text" ref="name">
  <button @click="handleClick">Click me</button>  -->
  <!-- Teleport -->
  <!-- <teleport to=".modals" v-if="showModal">
    <ModalV theme="sale" @close="toggleModal">
      <template v-slot:links>
        <a href="#">Sign up now</a>

        <a href="#">More info</a>
      </template>
      <h1>Correct Giveaway!</h1>
      <p>Grab your training for HALVE price!</p>
    </ModalV>
  </teleport> -->
  <div v-if="showModal">
    <ModalV theme="sale" @close="toggleModal">
      <template v-slot:links>
        <a href="#">Sign up now</a>

        <a href="#">More info</a>
      </template>
      <h1>Correct Giveaway!</h1>
      <p>Grab your training for HALVE price!</p>
    </ModalV>
  </div>
  <div v-if="showModal2">
    <ModalV theme="greed" @close="toggleModal2">
      <template v-slot:links2>
        <a href="#">Sign up now</a>

        <a href="#">More info</a>
      </template>
      <h1>Wrong Giveaway!</h1>
      <p>Grab your training for DOUBLE price!</p>
    </ModalV>
  </div>

  <button @click="toggleModal">Open Modal</button>
  <button @click="toggleModal2">Open Modal</button>
</template>

<script>
import ModalV from './components/ModalV.vue'



export default {
  name: 'App',
  data() {
    return {
      title: 'My First Vue App',
      // header: 'Sign up for the Giveaway!',
      // text: 'Grab your training for halve price!',
      showModal: false,
      showModal2: false

    }
  },
  methods: {
    // handleClick() {
    //   console.log(this.$refs.name)
    //   this.$refs.name.classList.add('active')
    //   this.$refs.name.focus()
    // }
    toggleModal() {
      this.showModal = !this.showModal;
    },
    toggleModal2() {
      this.showModal2 = !this.showModal2;
    }
  },
  components: {
    ModalV
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

h1 {
  border-bottom: 1px solid #ddd;
  display: inline-block;
  padding-bottom: 10px;
}
</style>
