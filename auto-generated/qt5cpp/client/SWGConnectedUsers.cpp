/**
 * BitMEX API
 * ## REST API for the BitMEX Trading Platform  _If you are building automated tools, please subscribe to the_ _[BitMEX API RSS Feed](https://blog.bitmex.com/api_announcement/feed/) for changes. The feed will be updated_ _regularly and is the most reliable way to get downtime and update announcements._  [View Changelog](/app/apiChangelog)  -  #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  _All_ table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  _This is only a small subset of what is available, to get you started._  Fill in the parameters and click the `Try it out!` button to try any of these queries.  - [Pricing Data](#!/Quote/Quote_get)  - [Trade Data](#!/Trade/Trade_get)  - [OrderBook Data](#!/OrderBook/OrderBook_getL2)  - [Settlement Data](#!/Settlement/Settlement_get)  - [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)  -  ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


#include "SWGConnectedUsers.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {

SWGConnectedUsers::SWGConnectedUsers(QString json) {
    init();
    this->fromJson(json);
}

SWGConnectedUsers::SWGConnectedUsers() {
    init();
}

SWGConnectedUsers::~SWGConnectedUsers() {
    this->cleanup();
}

void
SWGConnectedUsers::init() {
    users = 0;
    m_users_isSet = false;
    bots = 0;
    m_bots_isSet = false;
}

void
SWGConnectedUsers::cleanup() {


}

SWGConnectedUsers*
SWGConnectedUsers::fromJson(QString json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGConnectedUsers::fromJsonObject(QJsonObject pJson) {
    ::Swagger::setValue(&users, pJson["users"], "qint32", "");
    
    ::Swagger::setValue(&bots, pJson["bots"], "qint32", "");
    
}

QString
SWGConnectedUsers::asJson ()
{
    QJsonObject obj = this->asJsonObject();
    QJsonDocument doc(obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject
SWGConnectedUsers::asJsonObject() {
    QJsonObject obj;
    if(m_users_isSet){
        obj.insert("users", QJsonValue(users));
    }
    if(m_bots_isSet){
        obj.insert("bots", QJsonValue(bots));
    }

    return obj;
}

qint32
SWGConnectedUsers::getUsers() {
    return users;
}
void
SWGConnectedUsers::setUsers(qint32 users) {
    this->users = users;
    this->m_users_isSet = true;
}

qint32
SWGConnectedUsers::getBots() {
    return bots;
}
void
SWGConnectedUsers::setBots(qint32 bots) {
    this->bots = bots;
    this->m_bots_isSet = true;
}


bool
SWGConnectedUsers::isSet(){
    bool isObjectUpdated = false;
    do{
        if(m_users_isSet){ isObjectUpdated = true; break;}
        if(m_bots_isSet){ isObjectUpdated = true; break;}
    }while(false);
    return isObjectUpdated;
}
}

