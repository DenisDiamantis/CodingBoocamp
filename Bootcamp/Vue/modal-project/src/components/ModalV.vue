<template>
    <div class="backdrop" @click.self="closeModal">
        <div class="modal" :class="theme">
            <!-- <h1>{{ header }}</h1>
            <p>{{ text }}</p> -->
            <slot></slot>
            <div class="actions2">
                <slot name="links2"></slot>
            </div>
            <div class="actions">
                <slot name="links"></slot>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    props: ['theme'],
    methods: {
        closeModal() {
            this.$emit('close')
        }
    }
}

</script>

<style>
.modal {
    width: 400px;
    padding: 20px;
    margin: 100px auto;
    background: white;
    border-radius: 10px;
}

.backdrop {
    top: 0;
    position: fixed;
    background: rgba(0, 0, 0, 0.5);
    width: 100%;
    height: 100%;
}

.modal h1 {
    color: #03cfb4;
    border: none;
    padding: 0;
}

.modal p {
    font-style: normal;
}

.modal.sale {
    background: green;
    color: white;
}

.modal.sale h1 {
    color: white;
}

.modal.greed {
    background: crimson;
    color: white;
}

.modal.greed h1 {
    color: white;
}

.modal .actions {
    text-align: center;
    margin: 30px 0 10px 0;
    color: #333;
}

.modal .actions a {
    color: #333;
    padding: 8px;
    border: 1px solid #eee;
    border-radius: 4px;
    text-decoration: none;
    margin: 10px;
}

.modal .actions2 {
    text-align: center;
    margin: 30px 0 10px 0;
    color: #333;
}

.modal .actions2 a {
    color: #333;
    padding: 8px;
    border: 1px solid #eee;
    border-radius: 4px;
    text-decoration: none;
    margin: 10px;
}
</style>