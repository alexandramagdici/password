import axios from '../node_modules/axios';

const httpPost = (url, data) => {
    return axios.post(url, data, {
      baseURL: 'https://localhost:44357/',
    });
  }

  export default {post: httpPost}
  