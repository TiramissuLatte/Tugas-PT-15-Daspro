import Vue from 'vue'
import App from './App'
import vuetify from './plugins/vuetify'
import router from './router'

Vue.config.productionTip = false

import 'vuetify/dist/vuetify.min.css'

new Vue({
  vuetify,
  router,
  render: h => h(App)
}).$mount('#app')