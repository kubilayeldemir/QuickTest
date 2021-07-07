<template>
  <div class="bg-light ps-3 mb-2 border border-primary">
    <span class="m-0 fw-bold border border-primary">{{ step.stepNumber }}</span>
    <div class="form-group col-md-4 mt-1">
      <div class="form-group w-25">
        <label for="stepNumber">Step Number:</label>
        <input id="stepNumber" v-model.number="step.stepNumber" class="form-control" placeholder="-999...999"
               type="number">
      </div>
      <div class="mt-2">
        <label for="action">Select Test Step Action</label>
        <select id="action" v-model="step.action" class="form-control" @change="resetStep">
          <option selected value="GoTo">Go To Website</option>
          <option selected value="Click">Click to Element</option>
          <option selected value="SendText">Write Text To Element</option>
        </select>
      </div>
    </div>
    <form v-if="step.action==='GoTo'" class="mt-2">
      <div class="row w-50">
        <div class="col">
          <label for="action">Write website address to go</label>
          <input v-model="step.actionText" class="form-control" placeholder="Website Address" type="text">
        </div>
      </div>
    </form>
    <form v-if="step.action==='Click' || step.action==='SendText'" class="mt-2">
      <div class="row w-75">
        <div class="col-lg">
          <label for="by">Find Element By:</label>
          <select id="by" v-model="step.by" class="form-control">
            <option selected value="Id">By Id</option>
            <option selected value="ClassName">By ClassName</option>
            <option selected value="Xpath">By Xpath</option>
          </select>
        </div>
        <div class="col-lg">
          <label for="action">Element Address to find by {{ step.by }}</label>
          <input v-model="step.elementAddress" class="form-control" placeholder="Website Address" type="text">
        </div>
        <div v-if="step.action==='SendText'" class="col-lg">
          <label for="action">Text you want to write to element:</label>
          <input v-model="step.actionText" class="form-control" placeholder="Website Address" type="text">
        </div>
      </div>
    </form>
    <hr/>
  </div>
</template>

<script>
export default {
  name: "TestStepCreate",
  data() {
    return {
      step: {
        action: null,
        actionText: null,
        by: null,
        elementAddress: null,
        stepNumber: 0
      }
    }
  },
  methods: {
    resetStep() {
      this.step.by = null
      this.step.elementAddress = null
      this.step.actionText = null
    },
    commitStep() {
      this.$store.commit("pushStepToCreateList", this.step)
    }
  }
}
</script>

<style scoped>

</style>
