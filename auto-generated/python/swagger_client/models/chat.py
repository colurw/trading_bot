# coding: utf-8

"""
    BitMEX API

    ## REST API for the BitMEX Trading Platform  _If you are building automated tools, please subscribe to the_ _[BitMEX API RSS Feed](https://blog.bitmex.com/api_announcement/feed/) for changes. The feed will be updated_ _regularly and is the most reliable way to get downtime and update announcements._  [View Changelog](/app/apiChangelog)  -  #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  _All_ table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  _This is only a small subset of what is available, to get you started._  Fill in the parameters and click the `Try it out!` button to try any of these queries.  - [Pricing Data](#!/Quote/Quote_get)  - [Trade Data](#!/Trade/Trade_get)  - [OrderBook Data](#!/OrderBook/OrderBook_getL2)  - [Settlement Data](#!/Settlement/Settlement_get)  - [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)  -  ## All API Endpoints  Click to expand a section.   # noqa: E501

    OpenAPI spec version: 1.2.0
    Contact: support@bitmex.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six

from swagger_client.configuration import Configuration


class Chat(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'id': 'int',
        '_date': 'datetime',
        'user': 'str',
        'user_color': 'str',
        'message': 'str',
        'html': 'str',
        'channel_id': 'float'
    }

    attribute_map = {
        'id': 'id',
        '_date': 'date',
        'user': 'user',
        'user_color': 'userColor',
        'message': 'message',
        'html': 'html',
        'channel_id': 'channelID'
    }

    def __init__(self, id=None, _date=None, user=None, user_color=None, message=None, html=None, channel_id=None, _configuration=None):  # noqa: E501
        """Chat - a model defined in Swagger"""  # noqa: E501
        if _configuration is None:
            _configuration = Configuration()
        self._configuration = _configuration

        self._id = None
        self.__date = None
        self._user = None
        self._user_color = None
        self._message = None
        self._html = None
        self._channel_id = None
        self.discriminator = None

        if id is not None:
            self.id = id
        self._date = _date
        self.user = user
        if user_color is not None:
            self.user_color = user_color
        self.message = message
        self.html = html
        if channel_id is not None:
            self.channel_id = channel_id

    @property
    def id(self):
        """Gets the id of this Chat.  # noqa: E501


        :return: The id of this Chat.  # noqa: E501
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this Chat.


        :param id: The id of this Chat.  # noqa: E501
        :type: int
        """

        self._id = id

    @property
    def _date(self):
        """Gets the _date of this Chat.  # noqa: E501


        :return: The _date of this Chat.  # noqa: E501
        :rtype: datetime
        """
        return self.__date

    @_date.setter
    def _date(self, _date):
        """Sets the _date of this Chat.


        :param _date: The _date of this Chat.  # noqa: E501
        :type: datetime
        """
        if self._configuration.client_side_validation and _date is None:
            raise ValueError("Invalid value for `_date`, must not be `None`")  # noqa: E501

        self.__date = _date

    @property
    def user(self):
        """Gets the user of this Chat.  # noqa: E501


        :return: The user of this Chat.  # noqa: E501
        :rtype: str
        """
        return self._user

    @user.setter
    def user(self, user):
        """Sets the user of this Chat.


        :param user: The user of this Chat.  # noqa: E501
        :type: str
        """
        if self._configuration.client_side_validation and user is None:
            raise ValueError("Invalid value for `user`, must not be `None`")  # noqa: E501

        self._user = user

    @property
    def user_color(self):
        """Gets the user_color of this Chat.  # noqa: E501


        :return: The user_color of this Chat.  # noqa: E501
        :rtype: str
        """
        return self._user_color

    @user_color.setter
    def user_color(self, user_color):
        """Sets the user_color of this Chat.


        :param user_color: The user_color of this Chat.  # noqa: E501
        :type: str
        """

        self._user_color = user_color

    @property
    def message(self):
        """Gets the message of this Chat.  # noqa: E501


        :return: The message of this Chat.  # noqa: E501
        :rtype: str
        """
        return self._message

    @message.setter
    def message(self, message):
        """Sets the message of this Chat.


        :param message: The message of this Chat.  # noqa: E501
        :type: str
        """
        if self._configuration.client_side_validation and message is None:
            raise ValueError("Invalid value for `message`, must not be `None`")  # noqa: E501

        self._message = message

    @property
    def html(self):
        """Gets the html of this Chat.  # noqa: E501


        :return: The html of this Chat.  # noqa: E501
        :rtype: str
        """
        return self._html

    @html.setter
    def html(self, html):
        """Sets the html of this Chat.


        :param html: The html of this Chat.  # noqa: E501
        :type: str
        """
        if self._configuration.client_side_validation and html is None:
            raise ValueError("Invalid value for `html`, must not be `None`")  # noqa: E501

        self._html = html

    @property
    def channel_id(self):
        """Gets the channel_id of this Chat.  # noqa: E501


        :return: The channel_id of this Chat.  # noqa: E501
        :rtype: float
        """
        return self._channel_id

    @channel_id.setter
    def channel_id(self, channel_id):
        """Sets the channel_id of this Chat.


        :param channel_id: The channel_id of this Chat.  # noqa: E501
        :type: float
        """

        self._channel_id = channel_id

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(Chat, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, Chat):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, Chat):
            return True

        return self.to_dict() != other.to_dict()
