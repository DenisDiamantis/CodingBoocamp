<template>
    <div class="result">
        <h3>Your time was {{ time }} ms</h3>
    </div>
    <div v-if="time < 600" class="result">
        <p>You are the Flash</p>
    </div>
    <div v-else-if="time < 1000">
        <p>You are Looky Looc</p>
    </div>
    <div v-else>
        <p>You are a merely human</p>
    </div>
</template>
<script>
export default {
    name: 'EndScreen',
    props: ['time'],
    methods: {

    }
}
</script>

<style>
h3 {
    margin: auto;
    border: none;
    padding: 0;
    width: 60%;
}

p {
    margin: auto;
    width: 60%;
}
</style>