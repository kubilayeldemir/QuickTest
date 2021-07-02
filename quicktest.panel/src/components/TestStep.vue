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
        <div class="card-body ">
          <div class="row">
            <div class="col-md-8 text-success">
              <h5 class="card-title">{{ step.status ? 'Step Passed' : 'Step Failed' }}</h5>
              <p class="card-text" style="font-size: 0.8em">{{ step.stepDescription }}</p>
            </div>
            <div class="col-md-4">
              <img :src="step.stepImageUrl" class="img-responsive" style="max-width: 100%;"/>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "TestStep",
  props: {
    step: Object
  }
}
</script>

<style scoped>

</style>
