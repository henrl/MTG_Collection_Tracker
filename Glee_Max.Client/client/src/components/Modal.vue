<template>
    <b-modal>
        <slot></slot>
    </b-modal>
</template>

<script>
export default {
    name: 'Modal',
    props: {
        data: Object
    }
}
</script>