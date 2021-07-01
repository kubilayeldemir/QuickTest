<script>
export default {
  name: "ReportCard",
  data(){
    return{
    }
  },
  props:{
    report:Object
  },
  components:{
  },
  computed: {
    testDurationSeconds() {
      let startDate = this.$moment(this.report.testStartDate)
      let endDate = this.$moment(this.report.testEndDate)

      return endDate.diff(startDate,"seconds");
    }
  },
  methods:{
  }
}
</script>

<style scoped>

</style>
<template>
  <div class="card text-white mb-3" style="max-width: 18rem;" :class="report.status ? 'bg-success' : 'bg-danger' ">
<!--    <div class="card text-white bg-danger mb-3" style="max-width: 18rem;">-->
    <div class="card-header"><span>{{ report.testStartDate | moment('h:mm A YYYY-MM-DD') }}</span></div>
    <div class="card-body">
      <h5 class="card-title" v-if="report.status">Test Passed</h5>
      <h5 class="card-title" v-else>Test Failed!</h5>
      <p class="card-text mb-0">Started at: {{ report.testStartDate | moment('h:mm:ss ') }} </p>
      <p class="card-text mb-0">End at: {{ report.testEndDate | moment('h:mm:ss ') }} </p>
      <p class="card-text mb-0">Took: {{ testDurationSeconds }} seconds </p>
      <p class="card-text mb-0 text-truncate" v-if="!report.status">{{ report.errorMessage }}</p>




    </div>
  </div>
</template>
