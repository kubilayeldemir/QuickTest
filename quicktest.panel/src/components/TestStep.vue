<template>
  <div class="container row">
    <div class="col-lg-12">
      <div :class="step.status ? 'border-success':'border-danger'" class="card mb-3">
        <div class="card-header">
          {{ step.stepNumber }}. Step
          <span :class="step.status ? 'bg-success':'bg-danger'" class="badge ms-1">{{
              step.status ? 'Success' : 'Failed'
            }}</span>
          <span class="ms-5">{{ step.stepDate | moment('h:mm:ss ') }}</span>
        </div>
        <div class="card-body mt-0 pt-1">
          <div class="row">
            <div class="col-md-8 text-success">
              <h5 class="card-title">{{ step.status ? 'Step Passed' : 'Step Failed' }}</h5>
              <p style="cursor: pointer" @click="toggleDescription=!toggleDescription">
                {{ toggleDescription ? "Close" : "Open" }} Test Description</p>
              <p v-if="toggleDescription" class="card-text" style="font-size: 0.8em; color: black">{{ step.stepDescription }}</p>
            </div>
            <div class="col-md-4">
              <span>Screenshot:</span>
              <vue-expandable-image :close-on-background-click="true" :src="step.stepImageUrl"></vue-expandable-image>
              <!--              <img :src="step.stepImageUrl" class="img-responsive" style="max-width: 100%;"/>-->
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import vueExpandableImage from 'vue-expandable-image/src/ExpandableImage'

export default {
  name: "TestStep",
  data() {
    return {
      toggleDescription: false
    }
  },
  props: {
    step: Object
  },
  components: {
    vueExpandableImage
  }
}
</script>

<style scoped>

</style>
